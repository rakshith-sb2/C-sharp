import React,{useState} from 'react'
export const SimpleInterest = () => {
    const [principal,setPrincipal] =useState()
    const [rate,setRate] =useState()
    const [time,setTime] =useState()
    const [si,setSi] =useState()
    const calculateInterest=()=>{
        let simpleInterest = (parseFloat(principal)*parseFloat(rate)*parseFloat(time))/100
        setSi(simpleInterest)
    }
return (
    <div>
    <input value={principal} onChange={(e)=>{setPrincipal(e.target.value)}} placeholder="Enter Principal"/>
    <input value={rate} onChange={(e)=>{setRate(e.target.value)}} placeholder="Enter Rate of Interest"/>
    <input value={time} onChange={(e)=>{setTime(e.target.value)}} placeholder="Enter Time in years"/>
    <button onClick={calculateInterest}>Calculate</button>
    <h1>Simple Interest is {si}</h1>

    </div>
  )
}
