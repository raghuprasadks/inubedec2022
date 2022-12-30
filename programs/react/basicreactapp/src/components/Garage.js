import React,{Component} from 'react'
import Car from './Car';

export default class Garage extends Component {
    render() {
      return (
        <div>
        <h1>Who lives in my Garage?</h1>
        <Car />
        </div>
      );
    }
  }