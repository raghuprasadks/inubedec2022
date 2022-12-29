import logo from './logo.svg';
import './App.css';
import Header from './Header';
import Content from './Content';
import DemoForm from './components/DemoForm';
import SimpleInterest from './components/SimpleInterest';
import GroceryList from './components/GroceryList';
import Employee from './components/Employee';
import Fifa from './components/Fifa';
function App() {

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
    
  return (
    <div>
      <h1>Welcome to React</h1>
      {/**
      <Header/>
      <Content/>
      <DemoForm></DemoForm>
      <SimpleInterest/>
      <GroceryList/>
      <Employee empData={emp}></Employee>
 */}
      
      <Fifa fifaData={fifaData}></Fifa>
      
      </div>
  );
}

export default App;
