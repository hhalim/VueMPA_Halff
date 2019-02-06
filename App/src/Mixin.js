import { version } from '../package.json';

export default {
  data: function () {
    return {
      appVersion: version,
      toastError: {
        type: 'error',
        theme: 'bubble',
        duration: 5000,
        icon: 'fa-exclamation-triangle',
        action: {
          icon: 'fa-times',
          onClick: (e, toastObject) => {
            toastObject.goAway(0);
          }
        }
      },
      toastSuccess: {
        type: 'success',
        theme: 'bubble',
        duration: 5000,
        icon: 'fa-check-circle',
        action: {
          icon: 'fa-times',
          onClick: (e, toastObject) => {
            toastObject.goAway(0);
          }
        }
      },
      toastInfo: {
        type: 'info',
        theme: 'bubble',
        duration: 5000,
        icon: 'fa-info-circle',
        action: {
          icon: 'fa-times',
          onClick: (e, toastObject) => {
            toastObject.goAway(0);
          }
        }
      }
    }
  }
}

