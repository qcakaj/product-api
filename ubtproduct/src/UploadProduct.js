import './App.css';
import React, { useState, useEffect } from "react";
import Button from '@material-ui/core/Button';
import TextComponent from './components/TextComponent';
import SelectComponents from './components/SelectComponent';
import { makeStyles } from '@material-ui/core/styles';
import axios from 'axios';



const useStyles = makeStyles({
    root: {
      paddingTop:12,
      paddingBottom:200
    },
    media: {
      height: 140,
    },
    category_wrapper: {
        marginbottom:200
    }

  });

function UploadProduct() {
    const classes = useStyles();
    const [productName, setProductName] = useState('') 
    const [productCategory,setProductCategory] = useState('')

   const uploadProduct = () => {
       axios.post('http://localhost:5000/api/products',{name:"qendrim",active:true,image:"asdasd",category: null})
   }
         const handleClick = () => {
             uploadProduct();
         }
     
    

    const handleChange = (e) => setProductName(e.target.value)
    const handleCategoryChange = (e) => setProductCategory(e.target.value)

    console.log(productName)
    console.log(productCategory)
 return (
 <div style={{display:'block',justifyContent:'center',alignItems:'center'}}>
     <div style={{display: 'flex',  justifyContent:'center', alignItems:'center'}}>
 <TextComponent productLabel="Product Name" handleChange={handleChange}/>
 <SelectComponents handleCategoryChange={handleCategoryChange}/>
 </div>
 <div style={{textAlign:'center'}}>
<img  style= {{width: '25ch',height:'25ch', objectFit:"cover",}}src="https://images.unsplash.com/photo-1616521528192-97d354151036?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=934&q=80"></img>
</div>
 <div style={{display:'flex',justifyContent:'center',alignItems:'center',marginTop:'5ch'}}>
<Button variant="outlined" color="primary" onClick={handleClick}>
  Upload
</Button>

</div>
 </div>)

}
export default UploadProduct;

