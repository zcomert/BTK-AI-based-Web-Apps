import React from 'react'
import Header from "../../components/header/Header"

export default function Product({ product }) {
  return (
    <div>
      <Header data={{ title: `${product?.name}` }}></Header>
      {product?.name}</div>
  )
}
