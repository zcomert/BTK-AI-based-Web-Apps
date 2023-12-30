import {
    createContext,
    useState,
    useEffect
} from "react";

import ProductService from "../services/ProductService";

const AppContext = createContext();

export const AppProvider = ({ children }) => {

    const [message, setMessage] = useState("Selam");
    const [products, setProducts] = useState(null);
    const [load, setLoad] = useState(true);

    useEffect(() => {
        const productService = new ProductService();
        productService
            .getAllProducts()
            .then(resp => {
                setTimeout(() => {
                    setProducts(resp);
                    setLoad(false);
                }, 2000);
            });
    }, []);

    const values = {
        load,
        setLoad,
        message,
        setMessage,
        products,
        setProducts
    }

    return (<AppContext.Provider value={values}>
        {children}
    </AppContext.Provider>);
}

export default AppContext;