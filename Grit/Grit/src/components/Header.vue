<template>
  <section class="sticky top-0 z-50">
    <nav>
      <div class="bg-white  border-b" x-data="{navigationOpen:false}">
        <div
          class="flex justify-between lg:container px-5 mx-auto w-full lg:w-11/12 py-3 items-center lg:border-none border-b"
        >
          <a href="" class="text-3xl uppercase font-mono"> grit </a>
          <div class="flex" x-data="{open:false}">
            <nav class="hidden lg:block">
              <ul class="flex items-center">
                <li
                  class="mx-1 font-medium uppercase text-xs hover:text-gray-500 rounded-md p-2 duration-300"
                >
                  <a href="">Home</a>
                </li>
                <li
                  class="mx-1 font-medium uppercase text-xs hover:text-gray-500 rounded-md p-2 duration-300"
                >
                  <a href="">Our product</a>
                </li>
                <li
                  class="mx-1 font-medium uppercase text-xs hover:text-gray-500 rounded-md p-2 duration-300"
                >
                  <a href="">About</a>
                </li>
                <li
                  class="mx-1 font-medium uppercase text-xs hover:text-gray-500 rounded-md p-2 duration-300"
                >
                  <a href="">Contact</a>
                </li>
                <li
                  class="mx-1 font-medium uppercase text-xs hover:text-gray-500 rounded-md p-2 duration-300"
                >
                  <a href="">Styleguide</a>
                </li>
                <li
                  class="mx-1 font-medium uppercase text-xs hover:text-gray-500 rounded-md p-2 duration-300"
                >
                  <a href="">Contact</a>
                </li>
                <li
                  class="mx-1 font-medium uppercase text-xs hover:text-gray-500 rounded-md p-2 duration-300"
                >
                  <a href="">License</a>
                </li>
              </ul>
            </nav>
            <button
              class="flex items-center hover:opacity-70 py-1 px-3 rounded-md relative p-2 duration-300"
            >
              <img
                src="https://assets.website-files.com/5d9d08afa8a650dd43830c03/5d9d08afa8a6502f8e830c6e_Cart%20Icon%402x.png"
                class="w-4 h-4"
                alt=""
              />
              <div
                class="w-4 h-4 text-black bg-white rounded-full flex justify-center items-center"
              >
                <sup> 0 </sup>
              </div>
            </button>
            <!-- Menu button -->
            <button
              x-on:click="navigationOpen = !navigationOpen"
              class="block lg:hidden py-3 mr-4 rounded-md"
            >
              <img
                src="https://assets.website-files.com/5d9d08afa8a650dd43830c03/5d9d08afa8a650d83b830c83_Menu%20Icon.png"
                class="w-4 h-4"
                alt=""
              />
            </button>
          </div>
        </div>
        <div
          x-on:click.away="navigationOpen = false"
          x-show="navigationOpen"
          class="lg:hidden absolute bg-white block text-center w-full px-8"
        >
          <ul class="items-center">
            <li
              class="my-4 text-left font-medium uppercase text-xs hover:text-gray-500 rounded-md p-2 duration-300"
            >
              <a href="">Home</a>
            </li>
            <li
              class="my-4 text-left font-medium uppercase text-xs hover:text-gray-500 rounded-md p-2 duration-300"
            >
              <a href="">Our product</a>
            </li>
            <li
              class="my-4 text-left font-medium uppercase text-xs hover:text-gray-500 rounded-md p-2 duration-300"
            >
              <a href="">About</a>
            </li>
            <li
              class="my-4 text-left font-medium uppercase text-xs hover:text-gray-500 rounded-md p-2 duration-300"
            >
              <a href="">Contact</a>
            </li>
            <li
              class="my-4 text-left font-medium uppercase text-xs hover:text-gray-500 rounded-md p-2 duration-300"
            >
              <a href="">Styleguide</a>
            </li>
            <li
              class="my-4 text-left font-medium uppercase text-xs hover:text-gray-500 rounded-md p-2 duration-300"
            >
              <a href="">Contact</a>
            </li>
            <li
              class="my-4 text-left font-medium uppercase text-xs hover:text-gray-500 rounded-md p-2 duration-300"
            >
              <a href="">License</a>
            </li>
          </ul>
        </div>
      </div>
    </nav>
  </section>
</template>
