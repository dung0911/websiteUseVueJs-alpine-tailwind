<script setup>
import shops from "../data/ShopClothes";
</script>
<template>
  <section>
    <div class="mx-auto w-11/12 xl:w-4/5">
      <p class="text-stone-400 text-center mb-6">SHOP CLOTHING</p>
      <h1 class="text-3xl text-center mb-20">Explore our latest pieces</h1>
      <div class="grid md:grid-cols-2 lg:grid-cols-4 gap-10 relative">
        <div class="" v-for="shop in shops" :key="shop.price">
          <a href="" class="hover:grayscale-25">
            <div
              class="relative group"
              style="
                background-position: center;
                background-repeat: no-repeat;
                background-size: cover;
              "
            >
              <img :src="shop.image" alt="" />
              <div
                class="group-hover:opacity-100 duration-500 left-40 md:left-20 lg:left-12 whitespace-nowrap shadow-2xl opacity-0 absolute bottom-5"
              >
                <button class="uppercase bg-white px-8 py-4">
                  view product
                </button>
              </div>
            </div>
          </a>
          <div class="my-5">
            <a href="" class="py-5 hover:text-gray-500 text-xl"
              >Grey & Blue Build Bridges Not Walls Tee</a
            >
            <p class="text-2xl my-2 font-medium">$ 29.50 USD</p>
          </div>
        </div>
      </div>
        <button class="bg-black flex justify-center items-center mx-auto my-10 px-3">
            <div
              class="group w-full flex font-normal text-white whitespace-nowrap text-md rounded-md uppercase justify-between px-4 py-4"
            >
              view all products
              <img
                src="../assets/Arrow.svg"
                class="ml-4 group-hover:translate-x-3 duration-500"
                alt=""
              />
            </div>
        </button>
    </div>
  </section>
</template>
