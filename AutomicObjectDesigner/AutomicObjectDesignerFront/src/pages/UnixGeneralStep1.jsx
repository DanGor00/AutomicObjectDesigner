import { data } from 'autoprefixer';
import React from 'react'
import { Form, NavLink } from 'react-bootstrap';
import { Navigate, useNavigate } from 'react-router-dom';
//TODO ALL
export const UnixGeneralStep1 = () => {
  const cssStyle = `bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg
   focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700
   dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500
   dark:focus:border-blue-500`;
   

   const [formData, setFormData] = React.useState(
    {
        UnixServer: "Option2", 
        UnixLogin: "Option2",
        SapSid: "Option2",
        SapClient: "Option2",
        RoutineJob: false,
        ProcessName: "",
        NameSuffix: "",
    }
    )

    function handleChange(event) {
      console.log(event)
      const {name, value, type, checked} = event.target
      setFormData(prevFormData => {
          return {
              ...prevFormData,
              [name]: type === "checkbox" ? checked : value
          }
      })
    }

    let Navigate = useNavigate();
  async function handleSubmit(event) {
    event.preventDefault()
    
    try {
      // console.log(formData)
      await fetch('https://localhost:7017/api/UnixGeneral/1', {
        method: 'post',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify(formData)
      }).then((response) => {return response.json() }).then((data) => console.log(data)).catch((error) => { console.log("!ERROR! " + error) })
    } catch (error) {
      console.log("ERROR" + error)
    }
    const id = 38;
    Navigate("/UnixGeneral/2", { state: id});
    //window.location.href = '/SAPJobBW/2/';
    //window.location.href =`/SAPJobBW/2/${id}`;
    //TODO need a solution for passing id to the next page
    // <Link to= state={/SAPJobBW/2/}></Link>
  }

  return (
    <div className='md:px-4 py-2.5 container w-800'>
      <form onSubmit={handleSubmit}>
        <label htmlFor="UnixServer" className="block mb-2 text-sm font-medium text-gray-900 dark:text-gray-400">Select Server</label>
              <select onChange={handleChange} value={formData.UnixServer} id="UnixServer" name='UnixServer' className={cssStyle}>
          <option value={"Option1"}>Option1</option>
          <option value={"Option2"}>Option2</option>
          <option value={"Option3"}>Option3</option>
          <option value={"Option4"}>Option4</option>
        </select>
        <label htmlFor="UnixLogin" className="block mb-2 text-sm font-medium text-gray-900 dark:text-gray-400 my-3">Select Windows Login Object</label>
              <select onChange={handleChange} value={formData.UnixLogin} id="UnixLogin" name='UnixLogin' className={cssStyle}>
              <option value={"Option1"}>Option1</option>
          <option value={"Option2"}>Option2</option>
          <option value={"Option3"}>Option3</option>
          <option value={"Option4"}>Option4</option>
        </select>
        <label htmlFor="SapSid" className="block mb-2 text-sm font-medium text-gray-900 dark:text-gray-400 my-3">Select SAP SID</label>
              <select onChange={handleChange} value={formData.SapClient} id="SapSid" name='SapSid' className={cssStyle}>
              <option value={"Option1"}>Option1</option>
          <option value={"Option2"}>Option2</option>
          <option value={"Option3"}>Option3</option>
          <option value={"Option4"}>Option4</option>
        </select>
        <label htmlFor="SapClient" className="block mb-2 text-sm font-medium text-gray-900 dark:text-gray-400 my-3">Select SAP Client</label>
              <select onChange={handleChange} value={formData.SapClient} id="SapClient" name='SapClient' className={cssStyle}>
              <option value={"Option1"}>Option1</option>
          <option value={"Option2"}>Option2</option>
          <option value={"Option3"}>Option3</option>
          <option value={"Option4"}>Option4</option>
        </select>
        <div className="flex items-center mb-4">
          <input id="RoutineJob" onChange={handleChange} value={formData.RoutineJob} name='RoutineJob' type="checkbox" className="w-4 h-4 text-blue-600 bg-gray-100 rounded border-gray-300 focus:ring-blue-500 dark:focus:ring-blue-600 dark:ring-offset-gray-800 focus:ring-2 dark:bg-gray-700 dark:border-gray-600" />
          <label htmlFor="RoutineJob" className="ml-2 text-sm font-medium text-gray-900 dark:text-gray-300 my-3">Routine Job</label>
        </div>
        <label htmlFor="ProcessName" className="block mb-2 text-sm font-medium text-gray-900 dark:text-gray-300">Process Name</label>
        <input type="text" onChange={handleChange} value={formData.ProcessName}  name='ProcessName' minLength="7" maxLength="7" id="ProcessName" className={cssStyle} required />
        <label htmlFor="NameSuffix" className="block mb-2 text-sm font-medium text-gray-900 dark:text-gray-300 my-3">Name suffix</label>
              <input type="text" onChange={handleChange} value={formData.NameSuffix} name='NameSuffix' maxLength="40" id="NameSuffix" className={cssStyle} required />
        <p></p>
        <button type="submit" className="text-white bg-blue-700 hover:bg-blue-800 focus:ring-4 focus:outline-none focus:ring-blue-300 font-medium rounded-lg text-sm w-full sm:w-auto px-5 py-2.5 text-right dark:bg-blue-600 dark:hover:bg-blue-700 dark:focus:ring-blue-800">Submit</button>
      </form>
    </div>
  )
}