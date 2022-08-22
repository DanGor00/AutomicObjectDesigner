import React from 'react';
import { Form } from 'react-bootstrap';
import InputGroup from 'react-bootstrap/InputGroup';
import FloatingLabel from 'react-bootstrap/FloatingLabel';

// need to refactor the style

const SapJobSimple = () => {
  return (
    <div className='md:px-4 py-2.5 container w-800'>
      <label for="SAP_SID" class="block mb-2 text-sm font-medium text-gray-900 dark:text-gray-400">Select SAP SID</label>
        <select id="SAP_SID" class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500">
          <option>Option1</option>
          <option>Option2</option>
          <option>Option3</option>
          <option>Option4</option>
        </select>
        <label for="SAP_Client" class="block mb-2 text-sm font-medium text-gray-900 dark:text-gray-400 my-3">Select SAP Client</label>
        <select id="SAP_Client" class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500">
          <option>Option1</option>
          <option>Option2</option>
          <option>Option3</option>
          <option>Option4</option>
        </select>
        <label for="SAP_Report" class="block mb-2 text-sm font-medium text-gray-900 dark:text-gray-400 my-3">SAP Report</label>
        <textarea id="SAP_Report" rows="4" class="block p-2.5 w-full text-sm text-gray-900 bg-gray-50
        rounded-lg border border-gray-300 focus:ring-blue-500 focus:border-blue-500 dark:bg-gray-700 dark:border-gray-600
        dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500" placeholder="SAP Report..."></textarea>
        <label for="SAP_Variant" class="block mb-2 text-sm font-medium text-gray-900 dark:text-gray-400 my-3">SAP Variant</label>
        <textarea id="SAP_Variant" rows="4" class="block p-2.5 w-full text-sm text-gray-900 bg-gray-50
        rounded-lg border border-gray-300 focus:ring-blue-500 focus:border-blue-500 dark:bg-gray-700 dark:border-gray-600
        dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500" placeholder="SAP Variant..."></textarea>
        <div class="flex items-center mb-4">
    <input id="routine-job" type="checkbox" value="" class="w-4 h-4 text-blue-600 bg-gray-100 rounded border-gray-300 focus:ring-blue-500 dark:focus:ring-blue-600 dark:ring-offset-gray-800 focus:ring-2 dark:bg-gray-700 dark:border-gray-600" />
    <label for="routine-job" class="ml-2 text-sm font-medium text-gray-900 dark:text-gray-300 my-3">Routine Job</label>
    </div>
    <label for="process_name" class="block mb-2 text-sm font-medium text-gray-900 dark:text-gray-300">Process Name</label>
            <input type="text" minLength="7" maxLength="7" id="process_name" class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500" placeholder="7 characters needed" required />
            <label for="process_name" class="block mb-2 text-sm font-medium text-gray-900 dark:text-gray-300 my-3">SAP Job Name</label>
            <input type="text" minLength="7" maxLength="7" id="process_name" class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500" placeholder="22 characters needed" required />
            <input id="delete-sap-job" type="checkbox" value="" class="w-4 h-4 my-3 text-blue-600 bg-gray-100 rounded border-gray-300 focus:ring-blue-500 dark:focus:ring-blue-600 dark:ring-offset-gray-800 focus:ring-2 dark:bg-gray-700 dark:border-gray-600" />
            <label for="delete-sap-job" class="ml-2 my-1 text-sm font-medium text-gray-900 dark:text-gray-300">Delete SAP Job</label>
            <p></p>
            <button type="submit" class="text-white bg-blue-700 hover:bg-blue-800 focus:ring-4 focus:outline-none focus:ring-blue-300 font-medium rounded-lg text-sm w-full sm:w-auto px-5 py-2.5 text-right dark:bg-blue-600 dark:hover:bg-blue-700 dark:focus:ring-blue-800">Submit</button>
    </div>
  )
}

export default SapJobSimple;