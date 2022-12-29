import logo from './logo.svg';
import './App.css';
import Header from './Header';
import Content from './Content';
import DemoForm from './components/DemoForm';
import SimpleInterest from './components/SimpleInterest';
import GroceryList from './components/GroceryList';
import Employee from './components/Employee';
function App() {

  const emp={
    code:1,
    name:'Naveen',
    dept:'IT',
    desg:'SE',
    sal:40000
  }
  return (
    <div>
      <h1>Welcome to React</h1>
      {/**
      <Header/>
      <Content/>
      <DemoForm></DemoForm>
      <SimpleInterest/>
      <GroceryList/>
 */}
      
      
      <Employee empData={emp}></Employee>
      </div>
  );
}

export default App;
