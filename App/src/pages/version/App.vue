<template>
  <div>
    <Navbar></Navbar>

    <div class="container main">
      <div class="row">
        <div class="col">
          <div class="row justify-content-md-center mt-4">
            <div class="col">

              <div class="card">
                <div class="card-body">
                  <h5 class="card-title">Revision History</h5>
                  <div style="padding-left: .75rem;">
                    <strong>19.2.5.2</strong>
                    <ul>
                      <li>Something is done</li>
                      <li>Something else is done</li>
                    </ul>

                    <strong>19.2.5.1</strong>
                    <ul>
                      <li>Initial version.</li>
                    </ul>
                  </div>
                </div>
              </div> <!-- /card -->

            </div> <!-- /col -->
          </div>
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
    name: 'Version',
    components: {
      Navbar,
      Footer,
    },
  }
</script>

<style scoped>
  main {
    color: black;
    /*padding-left: 2rem;
    padding-right: 2rem;*/
  }

  caption {
    caption-side: top;
  }

  .card-deck {
    margin-bottom: 1.5rem;
  }

  ul {
    padding-left: 2rem;
  }
</style>