import logo from './logo.svg';
import './App.css';
import Header from './Header';
import Content from './Content';
import DemoForm from './components/DemoForm';

function App() {
  return (
    <div>
      <h1>Welcome to React</h1>
      <Header/>
      <Content/>
      <DemoForm></DemoForm>
            </div>
  );
}

export default App;
