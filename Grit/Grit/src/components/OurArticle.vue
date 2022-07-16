<script setup>
import articals from "../data/OurArticle";
</script>

<template>
  <section>
    <div class="mx-auto w-11/12 xl:w-4/5 pb-24 border-b">
      <p class="text-gray-600">OUR ARTICLES</p>
      <h1 class="font-normal text-3xl">
        Welcome to the surf club. Discover <br />
        the best way to express yourself.
      </h1>
      <div class="grid grid-cols-1 md:grid-cols-4 gap-5 mt-12">
        <div
          v-for="(artical,index) in articals"
          :key="artical.desc"
          class="relative"
          style="min-height: 460px"
          :class="index == 2 ? 'md:col-span-2':'md:col-span-1'"
        >
          <img :src="artical.image" alt="" class="h-full" />
          <div
            class="absolute top-0 text-white p-8"
            style="background-color: rgba(24, 24, 29, 0.5); min-height: 460px"
          >
            <span class="p-2 uppercase border border-white">News</span>
            <button
              class="text-3xl my-10 font-normal text-left hover:text-gray-200"
              style=""
            >
              {{ artical.desc }}
            </button>
            <button
              class="bg-white flex justify-center items-center mx-auto px-3 absolute bottom-8"
            >
              <div
                class="group w-full flex font-normal text-black whitespace-nowrap text-md rounded-md uppercase justify-between px-4 py-4"
              >
                explore
                <img
                  src="https://assets.website-files.com/5d9d08afa8a650dd43830c03/5d9d08afa8a6500021830c44_arrow-dark%402x.svg"
                  class="ml-4 group-hover:translate-x-3 duration-500"
                  alt=""
                />
              </div>
            </button>
          </div>
        </div>
      </div>
    </div>
  </section>
</template>
