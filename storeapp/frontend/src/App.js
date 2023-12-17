import logo from './logo.svg';
import './App.css';
import Counter from './basic/Counter';
import EmployeeList from './basic/EmployeeList';
import { Link, Route, Routes } from 'react-router-dom';
import Contact from './basic/Contact';


function App() {
  return (
    <div>
      <div>
        Merhaba React.
      </div>

      <Routes>
        <Route path='/counter' element={<Counter />}></Route>
        <Route path='/employees' element={<EmployeeList />}></Route>
        <Route path='/contact' element={<Contact />}></Route>
      </Routes>

      <ul>
        <li>
          <Link to="/employees">Çalışanlar</Link>
        </li>
        <li>
          <Link to="/counter">Sayaç</Link>
        </li>
        <li>
          <Link to="/contact">İletişim</Link>
        </li>
      </ul>

    </div>
  );
}

export default App;
