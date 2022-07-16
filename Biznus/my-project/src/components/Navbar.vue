<template>
  <nav class="sticky top-0 z-50">
    <div class="bg-black p-2 lg:p-6 text-white items-center flex justify-center">
      <button class="bg-red-500 py-1 px-6 rounded-full text-md mr-4">
        Announcement
      </button>
      <span class="text-lg">How we're responding to COVID-19</span>
    </div>

    <div class="bg-red-500" x-data="{navigationOpen:false}">
      <div
        class="flex justify-between lg:container px-5 mx-auto w-full lg:w-11/12 py-3 text-white items-center"
      >
        <a href="">
          <img src="../assets/BiznusLogo.svg" alt="" />
        </a>
        <div class="flex" x-data="{open:false}">
          <nav class="hidden lg:block">
            <ul class="flex items-center">
              <li class="mx-4 hover:bg-gray-800 rounded-md p-2 duration-300">
                <a href="">Home</a>
              </li>
              <li class="mx-4 hover:bg-gray-800 rounded-md p-2 duration-300">
                <a href="">About</a>
              </li>
              <li class="mx-4 hover:bg-gray-800 rounded-md p-2 duration-300">
                <a href="">Shop</a>
              </li>
              <li class="mx-4 hover:bg-gray-800 rounded-md p-2 duration-300">
                <a href="">Donate</a>
              </li>
              <li class="mx-4 hover:bg-gray-800 rounded-md p-2 duration-300">
                <a href="">Contact</a>
              </li>
            </ul>
          </nav>
          <button
            class="flex items-center bg-gray-800 hover:bg-gray-600 py-1 px-3 rounded-md relative mx-4 p-2 duration-300"
          >
            <img src="../assets/cardIcon.svg" class="w-6 h-6" alt="" />
            <div
              class="w-4 h-4 absolute -top-2 -right-1 text-black bg-white rounded-full flex justify-center items-center"
            >
              0
            </div>
          </button>
          <!-- Menu button -->
          <button
            x-on:click="navigationOpen = !navigationOpen"
            class="block lg:hidden focus:bg-gray-800 py-3 px-6 rounded-md"
          >
            <i class="fa fa-reorder"></i>
          </button>
        </div>
      </div>
      <div
        x-on:click.away="navigationOpen = false"
        x-show="navigationOpen"
        class="text-center h-screen pt-24 min-h-screen w-full px-8"
      >
        <button class="w-full rounded-md hover:bg-black duration-150 py-3">
          <a class="text-3xl text-white font-seimibold">Home</a>
        </button>
        <button class="w-full rounded-md hover:bg-black duration-150 py-3">
          <a class="text-3xl text-white font-seimibold">About</a>
        </button>
        <button class="w-full rounded-md hover:bg-black duration-150 py-3">
          <a class="text-3xl text-white font-seimibold">Shop</a>
        </button>
        <button class="w-full rounded-md hover:bg-black duration-150 py-3">
          <a class="text-3xl text-white font-seimibold">Donate</a>
        </button>
        <button class="w-full rounded-md hover:bg-black duration-150 py-3">
          <a class="text-3xl text-white font-seimibold">Contact</a>
        </button>
      </div>
    </div>
  </nav>
</template>
