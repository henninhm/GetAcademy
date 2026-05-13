<template>
  <div>
    <input type="checkbox" id="todo-item" />
    <label for="todo-item">My Todo Item</label>
  </div>
</template>
<script>
import ToDoItem from "./ToDoItem.vue";

export default {
  name: "app",
  components: {
    ToDoItem,
  },
};
</script>