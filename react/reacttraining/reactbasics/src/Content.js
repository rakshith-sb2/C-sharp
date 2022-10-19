import React from 'react'

const Content = () => {
    const course = "MEAN/MERN"
    const wishlist = ['java fullstack','AI/ML','Blockchain']
    const emp = {code:1,name:'ravi',dept:'IT',desg:'SE'}
  return (
      <div>
    <h1>I am learning - {course}</h1>
    <h1> My wish list - {wishlist}</h1>
    <h2>My details - Code : {emp.code} - Name :{emp.name} </h2>
    </div>
  )
}

export default Content