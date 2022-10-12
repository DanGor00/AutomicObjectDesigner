import React from 'react'
import { Header } from '../components/Header';
import { useStateContext } from '../contexts/ContextProvider';
import { useEffect, useState } from 'react';

export const Files = () => {
  const buttonStyle="text-white static bg-blue-700 my-1 mx-5 hover:bg-blue-800 focus:ring-4 focus:outline-none focus:ring-blue-300 font-medium rounded-lg text-sm sm:w-auto px-5 py-2.5 dark:bg-blue-600 dark:hover:bg-blue-700 dark:focus:ring-blue-800"

  const [files, setFile] = useState([]);
  const [loading, setLoading] = useState(false);

  useEffect(() => {
    const fetchData = async () => {
      setLoading(true);
      try {
        const result = await fetch("https://localhost:7017/api/UserProfile/0", {
          headers: {'Authorization': 'Bearer ' + localStorage.getItem("token")}
        });
        const dataFetched = await result.json();
        if (dataFetched != null) {
          // document.getElementById("object").innerText = JSON.stringify(dat);
          setFile(dataFetched);
          // console.log(JSON.stringify(dataFetched));
          console.log(dataFetched);
        } else {
          console.warn("Data couldn't be fetched");
        }
      } catch (error) {
        console.error(error)
      }
      setLoading(false);
    }
    fetchData();
  }, []);

  return (
<div><p className='block mb-2 text-sm font-medium text-gray-900 dark:text-gray-300'>
  Files map here:
  </p>
  <ul>
{files?.windowsGenerals?.map((file)=>{ 
  console.log("Mapping through file: ");
  console.log(file);
  return(
  <li className='block mb-2 text-sm font-medium text-gray-900 dark:text-gray-300' key={file.id}>{file.id} {file.objectName}</li>
  )
})}
  </ul>
  <div className='dark:text-gray-300' id='object' />
</div>
  )
}