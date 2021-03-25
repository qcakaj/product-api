import './App.css';
import React, {  } from "react";
import { BrowserRouter as Router, Route } from 'react-router-dom';
import Home from './Home';
import UploadProduct from './UploadProduct';
import Navigation from "./Navigation"
import Footer from './Footer';
import { makeStyles } from '@material-ui/core/styles';


const useStyles = makeStyles({
  root: {
    paddingTop:12,
    paddingBottom:200
  },
  media: {
    height: 140,
  },
});
export default function App() {
  const classes = useStyles();
return (
<Router>
<Navigation />
<div className={classes.root}>
    <Route exact path="/" exact component={()=> <Home></Home>} />
    <Route path="/UploadProduct" exact component={()=><UploadProduct/>} />
    </div>
    <Footer/>
  </Router>
)
}

