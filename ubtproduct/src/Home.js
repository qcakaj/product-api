import './App.css';
import React, { useState, useEffect } from "react";
import axios from 'axios';
import AltCard from './components/AltCard'



function Home() {
  const [data, setData] = useState([]);
  const [isLoading, setIsLoading] = useState(false);
  const [isError, setIsError] = useState(false);



  useEffect(() => {
    const fetchData = async () => {
      setIsError(false);
      setIsLoading(true);
      const result = await axios(
        'http://localhost:5000/api/products',
      );
 
      setData(result.data);
      setIsLoading(false);
      console.log(result)
      console.log(result.data)
    };
 
    fetchData();
  }, [ ]);
 
  return (
    <div className="body">
    <ul className="flex-container">
{
  data.map((product) => {
    console.log((product).name)

   return <AltCard className="flex-item" product={product} />
  })
}  
</ul>
  </div>
  )

}
export default Home;

