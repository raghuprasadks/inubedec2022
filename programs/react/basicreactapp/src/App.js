import logo from './logo.svg';
import './App.css';
//import Header from './Header';
import Content from './Content';
import DemoForm from './components/DemoForm';
import SimpleInterest from './components/SimpleInterest';
import GroceryList from './components/GroceryList';
import Employee from './components/Employee';
import Fifa from './components/Fifa';
import Employees from './crud/Employees';
import {useState} from 'react'
import { FetchApiDemo } from './components/FetchAPIDemo';
import PostAPI from './components/PostAPI';
import ClassComponent from './components/ClassComponent';
import { ClassComponentState } from './components/ClassComponentState';
import Garage from './components/Garage';
import Header from './components/Header';
import Layout from './Layout';
import Home from './Home';
import Blogs from './Blogs';
import Contact from './Contact';
import NoPage from './NoPage';

function App() {
  const [employees,setEmployees]=useState([])
  const emp={
    code:1,
    name:'Naveen',
    dept:'IT',
    desg:'SE',
    sal:40000
  }

  const fifaData=[
    {
     code:1,
     name:'Argentina',
     year:2022,
     position:1 
    },
    {
     code:2,
     name:'France',
     year:2022,
     position:2 
    },
    {
     code:3,
     name:'Croatia',
     year:2022,
     position:3 
    }
    ]
    
    const addEmployee=({code,name,desg,sal})=>{
      const newemp = {code,name,desg,sal} 
      setEmployees([...employees,newemp])
      console.log('size of employee list',employees.length)
      console.log('after adding ',employees)
    }

    const deleteEmployee=(code)=>{
      const afterdel = employees.filter((emp)=>emp.code != code)
      setEmployees(afterdel)
    }
  return (
 
    <BrowserRouter>
    <Routes>
      <Route path="/" element={<Layout />}>
        <Route index element={<Home />} />
        <Route path="blogs" element={<Blogs />} />
        <Route path="contact" element={<Contact />} />
        <Route path="*" element={<NoPage />} />
      </Route>
    </Routes>
  </BrowserRouter>
  );
}

export default App;
