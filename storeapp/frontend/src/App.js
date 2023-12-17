import './App.css';
import Counter from './basic/Counter';
import EmployeeList from './basic/EmployeeList';
import { Route, Routes } from 'react-router-dom';
import Contact from './basic/Contact';
import Navbar from './components/navbar/Navbar';
import Footer from './components/footer/Footer';
import Home from './pages/home/Home';
import Products from './pages/products/Products';


function App() {
  return (
    <div>
      <header>
        <Navbar />
      </header>

      <main>
        <Routes>
          <Route path='/counter' element={<Counter />}></Route>
          <Route path='/employees' element={<EmployeeList />}></Route>
          <Route path='/contact' element={<Contact />}></Route>
          <Route path='/products' element={<Products />}></Route>
          <Route path='/' element={<Home />}></Route>
        </Routes>
      </main>

      <footer>
        <Footer></Footer>
      </footer>
    </div>
  );
}

export default App;
