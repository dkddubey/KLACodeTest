import React, { useEffect, useState } from 'react';

function NumberToWords() {
    const [inputValue, setInputValue] = useState('');
    const [apiResponse, setApiResponse] = useState('');
    const [isValid, setIsValid] = useState(true);
   
    const handleInputChange = (event) => {
      const value = event.target.value;
      const maxValue = 1000000000
      // Check if the input is a valid number
      const decimalRegex = /^\d+(\,\d{0,2})?$/;
      const isValidNumber = decimalRegex.test(value);
      setInputValue(value);
      setIsValid(isValidNumber);
    };
  
    const handleApiRequest = async () => {
        const apiUrl = 'https://localhost:7078/api/NumberToText/ConvertNumberToWords';
        const decimalNumber = inputValue.replace(",","."); // Replace with your decimal value
  
        // Constructing the URL with parameters
        const urlWithParams = new URL(apiUrl);
        urlWithParams.searchParams.append('inputNumber', decimalNumber);
  
      try {
          const response = await fetch(urlWithParams.toString());
  
        if (!response.ok) {
          throw new Error(`HTTP error! Status: ${response.status}`);
        }
  
        const data = await response.text();
        setApiResponse(data);
      } catch (error) {
        console.error('Fetch error:', error);
      }
    };
  
    return (
      <div>
          <h1>Convert number to string</h1>
          <p>This program can convert decimal number to words. Use comma(,) as decimal seperator.
            <br/>The input box can accept number with 2 decimal points and maximum possible number is 999999999,99.
            </p>
        <label>
          Input a number:
          <input
            type="text"
            value={inputValue}
            onChange={handleInputChange}
            style={{ borderColor: isValid ? 'initial' : 'red' }}
          />
        </label>
        <button onClick={handleApiRequest} disabled={!isValid} >Convert to words</button>
        {!isValid && <p style={{ color: 'red' }}>Please enter a valid number.</p>}
        <p>{apiResponse}</p>
      </div>
    );
  }
  
export default NumberToWords;