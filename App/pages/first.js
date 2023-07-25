import React, { useEffect, useState, useContext } from 'react'
import ClearSaleModule from '@behavior-analytics-sdk/react-native-clear-sale-module'
import { ApiContext } from '../stores/sessionStore'
import GeoLocation from 'react-native-geolocation-service'
import { View, Text, Platform, TouchableHighlight, PermissionsAndroid } from 'react-native'
import { useFocusEffect } from '@react-navigation/native'

const First = ({ navigation }) => {

    const [state, setState] = useContext(ApiContext);
    const [hasLocationPermission, setHasLocationPermission] = useState(false)
    const [userPosition, setUserPosition] = useState(false)

    useFocusEffect(
        React.useCallback(() => {
            loadPage()
        }, [])
    );

    useEffect(()=>{
        if( hasLocationPermission){
            GeoLocation.getCurrentPosition(position => {
                setUserPosition({
                    latitude: position.coords.latitude,
                    longitude: position.coords.longitude
                })
            }, error => {
                console.log("error get location",error)
            })
        }
    },[hasLocationPermission])

    const loadPage = async () => {
        if (Platform.OS === 'android') {
            if (!state.started) {
                await ClearSaleModule.start(state.token)
                setState({
                    ...state,
                    started: true
                })
            }
        }
            
        await verifyLocationPermissions()

        const id = await ClearSaleModule.generateSessionId(state.token)
        setState({
            ...state,
            sessionId: id
        })
    }

    const verifyLocationPermissions = async () => {
        if(Platform.OS === 'ios'){
            await GeoLocation.requestAuthorization("whenInUse")
            setHasLocationPermission(true);
        }else {
            try {
                const granted = await PermissionsAndroid.request(
                    PermissionsAndroid.PERMISSIONS.ACCESS_FINE_LOCATION
                )
                const grantedCoarse = await PermissionsAndroid.request(
                    PermissionsAndroid.PERMISSIONS.ACCESS_COARSE_LOCATION
                )
                if (granted === PermissionsAndroid.RESULTS.GRANTED && grantedCoarse === PermissionsAndroid.RESULTS.GRANTED) {
                    console.log('permissão concedida');
                    setHasLocationPermission(true);
                } else {
                    console.error('permissão negada');
                    setHasLocationPermission(false);
                }
            } catch (err) {
                console.warn(err);
            }
        }
    }

    return (
        <View style={{ flex: 1, justifyContent: 'center', alignItems: 'center' }}>
            <Text>Session_Id: {state.sessionId}</Text>
            <Text>Latitude: {userPosition.latitude}</Text>
            <Text>Longitude: {userPosition.longitude}</Text>
            <TouchableHighlight
                style={{
                    width: '85%',
                    height: '5%',
                    alignItems: 'center',
                    justifyContent: 'center',
                    borderRadius: 10,
                    marginTop: '5%',
                    backgroundColor: '#EB7004'
                }}
                onPress={() => {
                    navigation.navigate('MobileInformation')
                }}
                underlayColor='#FFF'
            >
                <Text style={{ fontSize: 16, color: '#fff'}}>Avançar</Text>
            </TouchableHighlight>
        </View>
    )
}

export default First