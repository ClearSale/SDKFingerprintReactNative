import React, { createContext, useState } from 'react'

export const ApiContext = createContext(null)

export const ApiContextProvider = props => {
    const [state, setState] = useState({
        token: 'generic-123',
        sessionId: '',
        started: false
    })

    return (
        <ApiContext.Provider value={[state, setState]}>
            {props.children}
        </ApiContext.Provider>
    )
}