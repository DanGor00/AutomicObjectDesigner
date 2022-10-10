import React from 'react';
import { useLocation, useNavigate} from 'react-router-dom';
import { useEffect } from 'react';
import { data } from 'autoprefixer';


export const ExportSite = () => {
  // const cssStyle = `bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg
  //  focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700
  //  dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500
  //  dark:focus:border-blue-500`;

  const { state } = useLocation();
  console.log(state.type);
  let Navigate = useNavigate();

  const url = 'https://localhost:7017/api/' + state.type;
  const getUrl = url + 'exportSite' + state.num;
  console.log("Fetching url: " + url)
  console.log("Get url: " +getUrl);
  useEffect(() => {
    const fetchData = async () => {
      try {
        const result = await fetch(getUrl, {
          headers: {'Authorization': 'Bearer ' + localStorage.getItem("token")}
        });
        const dat = await result.json();
        console.log(dat);
        if (dat != null) {
          console.log(dat);
          document.getElementById("object").innerText = JSON.stringify(dat);
        } else {
          console.warn("Data couldn't be fetched");
        }
      } catch (error) {
        console.error(error)
      }
    }
    fetchData();
  }, []);

  const [post, setPost] = React.useState(null);

  // let Navigate = useNavigate();
  async function handleClickCsv() {
    try {
      const SapJobResponse = await fetch(url + 'CsvFile/' + state.num, {
        headers: {'Authorization': 'Bearer ' + localStorage.getItem("token")}
      });
    } catch (error) {
      console.log("ERROR" + error)
    }
    const adres = url+"CsvFile/"+ state.num;
    console.log(adres)
    //Navigate("https://localhost:7017/api/WindowsGeneral/CsvFile/6")
    window.open(adres, '_blank', 'noopener,noreferrer');
    // window.open("https://localhost:7017/api/WindowsGeneral/CsvFile/11", '_blank', 'noopener,noreferrer');
  }

  async function handleClickXml() {
    try {
      Navigate(url+"DownloadXmlFile/"+ state.num);
    } catch (error) {
      console.log("ERROR" + error)
    }
    
    Navigate(url+"XmlFile/"+ state.num)
  }

  async function handleClickJson() {
    try {
      const SapJobResponse = await fetch(url + 'JsonFile/' + state.num, {
        headers: {'Authorization': 'Bearer ' + localStorage.getItem("token")}
      })
    } catch (error) {
      console.log("ERROR" + error)
    }
    window.open(url+"JsonFile/"+ state.num, '_blank', 'noopener,noreferrer');
    // const adres = url+"JsonFile/"+ state.num;
    // console.log(adres)
    // Navigate(url+"JsonFile/"+ state.num);
    // Navigate(adres);
  }


  

  // if (data.prop != null) {
  //   Navigate("/ExportSite", { state: { num: state, } });
  // } else {
  //   console.log("Id = null");
  // }



  return (
    <div className='md:px-4 py-2.5 container w-800'>
      <p className="block mb-2 text-sm font-medium text-gray-900 dark:text-gray-300 my-3">
        This is the object with your paramaters:
      </p>
      <div className='mp-2 font-blackcolumns-2 dark:text-gray-300' id='object'>
      </div>
      <div className='my-10'>
      {/* <button onClick={handleClickXml} type="button" className="my-4 text-white bg-blue-700 hover:bg-blue-800 focus:ring-4 focus:outline-none
      focus:ring-blue-300 font-medium rounded-lg text-sm w-full sm:w-auto px-5 py-2.5 text-right dark:bg-blue-600 dark:hover:bg-blue-700
      dark:focus:ring-blue-800">Export XML</button> */}
      {/* <a href='https://localhost:7017/api/WindowsGeneral/DownloadJsonFile/' download>Click to download json</a> */}
      <button onClick={handleClickJson} type="button" className="my-4 text-white bg-blue-700 hover:bg-blue-800 focus:ring-4 focus:outline-none
      focus:ring-blue-300 font-medium rounded-lg mx-4 text-sm w-full sm:w-auto px-5 py-2.5 text-right dark:bg-blue-600 dark:hover:bg-blue-700
      dark:focus:ring-blue-800">Export JSON</button>
      <button onClick={handleClickCsv} type="button" className="my-4 text-white bg-blue-700 hover:bg-blue-800 focus:ring-4 focus:outline-none
      focus:ring-blue-300 font-medium rounded-lg text-sm w-full sm:w-auto px-5 py-2.5 text-right dark:bg-blue-600 dark:hover:bg-blue-700
      dark:focus:ring-blue-800">Export CSV</button>
      </div>
    </div>
  )
}