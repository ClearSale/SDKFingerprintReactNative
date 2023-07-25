import React from 'react'
import First from './first'
import MobileInformation from './mobileInformation'
import { createStackNavigator } from '@react-navigation/stack'
import { NavigationContainer } from '@react-navigation/native'

const Stack = createStackNavigator()

const Routes = () => {
    return (
        <NavigationContainer>
            <Stack.Navigator>
                <Stack.Screen name='Home' component={First} />
                <Stack.Screen name='MobileInformation' component={MobileInformation} />
            </Stack.Navigator>
        </NavigationContainer>
    )
}

export default Routes