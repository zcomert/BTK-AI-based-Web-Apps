const { createContext, useState } = require("react");

const AppContext = createContext();

export const AppProvider = ({ children }) => {

    const [message, setMessage] = useState("Selam");

    const values = {
        message,
        setMessage
    }

    return (<AppContext.Provider value={values}>
        {children}
    </AppContext.Provider>);
}

export default AppContext;