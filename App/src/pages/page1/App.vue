<template>
  <div>
    <Navbar></Navbar>

    <div class="container main">
      <div class="row">
        <div class="col">
          <h1>Page 1</h1>
        </div>
      </div>
    </div>

    <Footer></Footer>
  </div>
</template>

<script>
  import Navbar from '../../components/Navbar.vue';
  import Footer from '../../components/Footer.vue';

  export default {
    name: 'Page1',
    components: {
      Navbar,
      Footer
    },
    data() {
      return {
      }
    },
    mounted() {
    },
    methods: {
    },
  }
</script>

<style scoped>
  .main {
    font-size: large;
    color: #fff;
  }
    .main a {
      color: inherit;
    }
</style>