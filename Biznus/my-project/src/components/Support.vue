<script setup>
import supports from "../data/Support";
</script>

<template>
  <section class="px-4 w-full lg:w-9/12 mx-auto my-16 overflow-hidden">
    <div class="lg:flex justify-between">
      <div class="w-1/2">
        <p>WAYS TO SUPPORT</p>
        <h1 class="font-bold text-4xl my-2">Support Acme Outdoors.</h1>
      </div>
      <p class="w-full lg:w-1/2 my-4">
        COVID-19 has forced us to close our retail space, but we need support
        from patrons like yourself now more than ever. Below, we’ve listed the
        best ways to help us through this season.
      </p>
    </div>
    <div class="mt-16 gap-10 grid grid-cols-1 lg:grid-cols-3">
      <div
        v-for="support of supports"
        :key="support.number"
        class="relative place-items-center"
      >
        <div class="">
          <div
            class="relative bg-black text-white w-full rounded-md"
            style="min-height: 300px"
          >
            <p class="absolute top-10 left-9 font-bold text-4xl">
              {{ support.number }}
            </p>
            <h1
              class="absolute top-1/3 text-center font-bold text-5xl w-full"
        :class="i === 1 ? ' top-1/2':'top-1/3'"
            >
              {{ support.title }}
            </h1>
            <div class="absolute -right-16" style="bottom: -25%">
              <img :src="support.image" alt="" />
            </div>
          </div>
          <p class="relative mt-10">
            {{ support.desc }}
          </p>
        </div>
      </div>
    </div>
  </section>
</template>
