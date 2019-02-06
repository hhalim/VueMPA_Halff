<template>
  <div class="footer">
    <div class="container">
      <div class="row">
        <div class="col-sm text-left">&copy; {{yearNow()}} Halff Associates, Inc.</div>
        <div class="col-sm text-right small align-self-end">
          <span class="host-env mr-1" :class="[nodeEnv]">{{nodeEnv}}</span>
          <span style="color: black;">
            <a href="/version.html">Version {{ this.appVersion }}</a>
          </span>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
  export default {
    name: "Footer",
    data() {
      return {
        nodeEnv: process.env.NODE_ENV,
      }
    },
    methods: {
      yearNow() {
        let d = new Date();
        return d.getFullYear();
      },
      detectIE() {
        var ua = window.navigator.userAgent;

        var msie = ua.indexOf('MSIE ');
        if (msie > 0) {
          // IE 10 or older => return version number
          return parseInt(ua.substring(msie + 5, ua.indexOf('.', msie)), 10);
        }

        var trident = ua.indexOf('Trident/');
        if (trident > 0) {
          // IE 11 => return version number
          var rv = ua.indexOf('rv:');
          return parseInt(ua.substring(rv + 3, ua.indexOf('.', rv)), 10);
        }

        var edge = ua.indexOf('Edge/');
        if (edge > 0) {
          // Edge (IE 12+) => return version number
          return parseInt(ua.substring(edge + 5, ua.indexOf('.', edge)), 10);
        }

        return false;
      }
    },
    mounted() {
      if (this.detectIE())
        alert("WARNING: Internet Explorer (IE) is not supported. This app may not work correctly.");
    }

  }
</script>

<style scoped>
  .host-env.development,
  .host-env.staging {
    background-color: indianred;
    color: white;
  }

  .footer {
    flex: none;
    position: absolute;
    width: 100%;
    bottom: 0;
    height: 3rem;

    color: #aaa;
  }
    .footer .container {
      padding: 0;
    }

    .footer a {
      color: #aaa;
      text-decoration: underline;
    }
</style>