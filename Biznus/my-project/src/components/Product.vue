<script setup>
import products from "../data/product";
</script>

<template>
  <section>
    <div class="w-11/12 lg:w-9/12 mx-auto my-14">
      <p>SHOP PRODUCTS</p>
      <h1 class="font-bold mt-4 mb-8 text-4xl">Open 24/7/365.</h1>
      <div class="grid grid-cols-1 lg:grid-cols-3 gap-3">
        <div class="mb-16" v-for="product in products" :key="product.title">
          <a href="">
            <img
              :src="product.image"
              class="w-full rounded-md"
              style="min-height: 500px"
              alt=""
            />
            <p class="items-center text-xl mt-4 flex justify-center">
              {{ product.title }}
            </p>
            <p
              class="items-center text-sm font-bold my-1 mb-4 flex justify-center"
            >
              {{ product.price }}
            </p>
          </a>
          <button
            class="flex mx-auto duration-500 px-8 py-2 rounded-md bg-red-400 text-white hover:bg-gray-800 hover:text-white text-md font-semibold"
          >
            Details
          </button>
        </div>
      </div>
      <button
        class="flex justify-center mx-auto duration-500 mb-24 px-8 py-2 rounded-md bg-gray-900 text-white hover:bg-red-500 hover:text-white text-sm font-semibold"
      >
        Read Our Statement
      </button>
    </div>
  </section>
</template>
