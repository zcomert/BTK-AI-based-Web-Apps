import logo from './logo.svg';
import './App.css';
import { useState } from 'react';

function App() {

  const [number, setNumber] = useState(0);

  function increase() {
    setNumber(number+1)
    console.log(number);
  }

  function decrease() {
    setNumber(number - 1);
    console.log(number);
  }

  return (
    <div>
       {number}
      <button onClick={increase} >Artır</button>
      <button onClick={decrease} >Azaltmak</button>
   </div>
  );
}

export default App;
