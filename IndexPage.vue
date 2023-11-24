<template>
   <button @click="sendMessage">SAY HELLO TO GODOT FROM QUASAR</button>
  <q-page class="flex flex-center">

    <iframe src="/Test.html" height="800" width="700" ref="GodotIframe"></iframe>
  </q-page>
</template>

<script>
import {
  onMounted,
  ref,
} from 'vue';

export default {
  setup() {
    const GodotIframe = ref(null);

    // Before the component is mounted, the value
    // of the ref is `null` which is the default
    // value we've specified above.
    var sendMessage = () => {
      GodotIframe.value.contentWindow.postMessage("HELLO GODOT FROM QUASAR", "*")
    }

    return {
      // It is important to return the ref,
      // otherwise it won't work.
      GodotIframe,
      sendMessage
    };
  },
};
</script>
