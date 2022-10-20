import './App.css';
import Header from './Header';
import Content from './Content';
import ClassComponent from './components/ClassComponent';
import { ClassComponentState } from './components/ClassComponentState';
import { DemoForm } from './components/DemoForm';
import { SimpleInterest } from './components/SimpleInterest';
import GroceryList from './components/GroceryList';
import IplComponent from './components/IplComponent';
import { FetchApiDemo } from './components/FetchAPIDemo';
import Jsonserverpostapi from './components/JsonServerPostAPI';
import TodoApp from './components/TodoApp';
function App() {
  const emp={
    id:1,
    name:"ravi",
    course:"React",
    duration:"7 days"
  }

  return (
    <div>
      <h1>Getting started with react</h1>
      {/**<Header></Header>
      <Content/>
      <ClassComponent course={emp}/>
      <ClassComponentState/>      
      <DemoForm/>
      <SimpleInterest/>
      <GroceryList></GroceryList>
  
      <IplComponent/>
      <FetchApiDemo></FetchApiDemo>
      <Jsonserverpostapi></Jsonserverpostapi>
      */}
    <TodoApp></TodoApp>
    </div>
  );
}

export default App;
