<template>
  <div>
    <Navbar></Navbar>

    <div class="container main">
      <div class="row">
        <div class="col">
          <h1>Sub Page 1</h1>
        </div>
      </div>
    </div>

    <Footer></Footer>
  </div>

</template>

<script>
  import Navbar from '../../../components/Navbar.vue';
  import Footer from '../../../components/Footer.vue';

  export default {
    name: 'SubPage1',
    components: {
      Navbar,
      Footer,
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