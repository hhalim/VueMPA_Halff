<template>
  <div>
    <Navbar></Navbar>

    <div class="container main">
      <div class="row">
        <div class="col">
          <h1>Index Page</h1>
          <hello-world></hello-world>
          <p>API Root: {{apiRoot}}</p>
          <button class="btn btn-primary" @click="showToast">Show Notification</button>
        </div>
      </div>
    </div>

    <Footer></Footer>
  </div>
</template>

<script>
  import Navbar from '../../components/Navbar.vue';
  import Footer from '../../components/Footer.vue';

  import HelloWorld from './components/HelloWorld.vue'; //sample sub component delete this

  export default {
    name: 'Index',
    components: {
      Navbar,
      Footer,
      HelloWorld
    },
    data() {
      return {
        apiRoot: process.env.VUE_APP_API_ROOT
      }
    },
    mounted() {
    },
    methods: {
      showToast() {
        this.$toasted.show('Toast sample message', this.toastInfo);
      }
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