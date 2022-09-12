import React from 'react';
import { Form } from 'react-bootstrap';
import InputGroup from 'react-bootstrap/InputGroup';
import FloatingLabel from 'react-bootstrap/FloatingLabel';


export const SapJobSimpleStep3 = () => {
  const cssStyle = `bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg
   focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700
   dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500
   dark:focus:border-blue-500`;

   const [formData, setFormData] = React.useState(
    {
        Docu: "",
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

    async function handleSubmit(event) {
        event.preventDefault()
        try {
          console.log(formData)
        await fetch('https://localhost:7017/api/SapSimple/create', {
          method: 'post',
          headers: {'Content-Type':'application/json'},
          body: JSON.stringify(formData)
      }).then ((response) => {console.log(response)}).catch ((error)=>{console.log(error)})
        } catch (error) {
          console.log(error)
        }
        }

  return (
    <div className='md:px-4 py-2.5 container w-800'>
      <p className="block mb-2 text-sm font-medium text-gray-900 dark:text-gray-300 my-3">
      </p>
      <form onSubmit={handleSubmit}>
        <label htmlFor="Docu" className="block mb-2 text-sm font-medium text-gray-900 dark:text-gray-400 my-3">Documentation</label>
        <textarea id="Docu" onChange={handleChange} value={formData.Docu} maxLength="255" name='Docu' rows="4" className={cssStyle} placeholder="Optional documentation."></textarea>
        <button type="submit" className="my-4 text-white bg-blue-700 hover:bg-blue-800 focus:ring-4 focus:outline-none
         focus:ring-blue-300 font-medium rounded-lg text-sm w-full sm:w-auto px-5 py-2.5 text-right dark:bg-blue-600 dark:hover:bg-blue-700
          dark:focus:ring-blue-800">Submit</button>
      </form>
    </div>
  )
}