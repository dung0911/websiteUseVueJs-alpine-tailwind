<script setup>
import types from "../data/TypeClothes";
</script>
<template>
  <section>
    <div class="mx-auto w-11/12 xl:w-4/5 mb-20">
      <div class="grid grid-cols-2 gap-8">
        <div v-for="type in types" :key="type.title" class="relative">
          <img
            :src="type.image"
            class="relative"
            style="min-height: 582px"
            alt=""
          />
          <div
            class="absolute bottom-7 left-3 lg:left-6 w-11/12 py-6 px-10 bg-white"
          >
            <a href="" class="text-3xl hover:text-gray-600 font-sans">{{
              type.title
            }}</a>
            <a
              href=""
              class="group w-1/2 hover:text-gray-700 uppercase text-xs font-medium"
            >
              <div class="flex items-center my-4">
                <span class="mr-5"> Explore all products </span>
                <svg
                  class="group-hover:translate-x-3 duration-500"
                  width="20px"
                  height="9px"
                  viewBox="0 0 20 9"
                  version="1.1"
                  xmlns="http://www.w3.org/2000/svg"
                  xmlns:xlink="http://www.w3.org/1999/xlink"
                >
                  <!-- Generator: Sketch 55.1 (78136) - https://sketchapp.com -->
                  <g
                    id="WIP"
                    stroke="none"
                    stroke-width="1"
                    fill="none"
                    fill-rule="evenodd"
                  >
                    <g
                      id="Artboard-Copy-8"
                      transform="translate(-306.000000, -5008.000000)"
                      fill="#18181D"
                    >
                      <path
                        d="M321.159111,5011.99364 L321.159111,5008.5 L326,5012.5 L321.159111,5016.5 L321.159111,5013.00636 L306,5013.00636 L306,5011.99364 L321.159111,5011.99364 Z"
                        id="Combined-Shape"
                      ></path>
                    </g>
                  </g>
                </svg>
              </div>
            </a>
          </div>
        </div>
      </div>
    </div>
  </section>
</template>
