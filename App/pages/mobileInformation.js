import React, { useContext, useEffect, useState } from 'react'
import { ApiContext } from '../stores/sessionStore'
import ClearSaleModule from '@behavior-analytics-sdk/react-native-clear-sale-module'
import { View, Text, Platform } from 'react-native'
import { useFocusEffect } from '@react-navigation/native'

const MobileInformation = ({ navigation }) => {

    const [state, setState] = useContext(ApiContext)
    const [send, setSend] = useState(false)
    const [loading, setLoading] = useState(true)

    useFocusEffect(
        React.useCallback(() => {
            loadPage()

        return () => {
            unloadPage()
            };
        }, [])
    );

    const loadPage = async () => {
        ClearSaleModule.collectDeviceInformation(state.token, state.sessionId).then(() => {
            console.log('id com sucesso', state.sessionId)
            setLoading(false)
            setSend(true)
        }).catch(() => {
            setLoading(false)
            setSend(false)
        })
    }

    const unloadPage = () => {
        if (Platform.OS === 'android') {
            ClearSaleModule.stop(state.token)
        }
    }

    return (
        <View style={{ flex: 1, justifyContent: 'center', alignItems: 'center'}}>
            <Text>Enviado com: {loading ? '...' : send ? 'Sucesso' : 'Error' }</Text>
        </View>
    )
}

export default MobileInformation