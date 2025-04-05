<script setup>
import {ref} from 'vue';

const count = ref(0);
</script>

<template>
	<div>
		<h2>This is a Vue component</h2>
		<button @click="count++">Count is: {{ count }}</button>
	</div>

</template>

<style scoped>
div {
	padding: 2rem;
	border: 1px solid #000;
}
</style>
