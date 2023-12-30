import './App.css';
import Counter from './basic/Counter';
import EmployeeList from './basic/EmployeeList';
import { Route, Routes } from 'react-router-dom';
import Contact from './basic/Contact';
import Navbar from './components/navbar/Navbar';
import Footer from './components/footer/Footer';
import Home from './pages/home/Home';
import Products from './pages/products/Products';
import ProductDetail from './pages/productDetail/ProductDetail';
import ResponsiveAppBar from './components/navbar/ResponsiveAppBar';
import Book from './basic/Book';
import BookWithFormik from './basic/BookWithFormik';
import ArrayManipulation from './basic/ArrayManipulation';
import ContextSample from './basic/ContextSample';
import Loading from './components/loading/Loading';
import { useContext } from 'react';
import AppContext from './context/AppContext';
import SimpleSnackBar from './components/simpleSnackBar/SimpleSnackBar';


function App() {
  const { load } = useContext(AppContext);
  return (
    <div>
      <header>
        <ResponsiveAppBar />
      </header>

      <main>
        {load && <Loading />}
        <SimpleSnackBar />
        <Routes>
          <Route path='/context' element={<ContextSample />}></Route>
          <Route path='/array' element={<ArrayManipulation />}></Route>
          <Route path='/bookwithformik' element={<BookWithFormik />}></Route>
          <Route path='/book' element={<Book />}></Route>
          <Route path='/counter' element={<Counter />}></Route>
          <Route path='/employees' element={<EmployeeList />}></Route>
          <Route path='/contact' element={<Contact />}></Route>
          <Route path='/products' element={<Products />}></Route>
          <Route path='/productdetail/:id' element={<ProductDetail />}></Route>
          <Route path='/' exact element={<Home />}></Route>
        </Routes>
      </main>

      <footer>
        <Footer></Footer>
      </footer>
    </div>
  );
}

export default App;
