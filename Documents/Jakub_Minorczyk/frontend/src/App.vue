<template>
  <img alt="Vue logo" src="./assets/logo.png">
  <img alt="C# logo" src="./assets/logo_2.png">
  
  <SimulatorForm msg="Symulator rozkazów procesora"/>
</template>

<script>
import SimulatorForm from './components/SimulatorForm.vue'

export default {
  name: 'App',
  components: {
    SimulatorForm
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
img {
  width: 200px;
  height: 200px;
}
</style>
