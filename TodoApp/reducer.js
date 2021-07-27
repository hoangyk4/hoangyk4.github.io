import storage from './util/storage.js'

const init = {
    todos: storage.get(),
    filter: 'all',
    filters: {
        all: () => true,
        active: todo => !todo.completed,
        completed: todo => todo.completed,
    },
    editIndex: null,
}

// cach 2: khai bao bien ben ngoai
const actions ={
    add({todos}, title){
        if (title){
            todos.push({title, completed: false})
            storage.set(todos)
        }
    },
    toggle({todos}, index){
        const todo = todos[index]
        todo.completed = !todo.completed
        storage.set(todos)
    },
    toggleAll({todos}, completed){
        todos.forEach(todo => todo.completed = completed)
        storage.set(todos)
    },
    destroy({todos}, index){
        todos.splice(index, 1)
        storage.set(todos)
    },
    switchFilter(state, filter){
        state.filter = filter
        storage.set(todos)

    },
    clearCompleted(state){
        state.todos = state.todos.filter(state.filters.active)
        storage.set(state.todos)
    },
    startEdit(state, index){
        state.editIndex = index
    },
    eventEdit(state, title){
        if(state.editIndex !== null){
            if(title){
                state.todos[state.editIndex].title = title
                storage.set(state.todos)
            } else{
                this.destroy(state, state.editIndex)
            }
            state.editIndex = null
        }
    },
    cancelEdit(state){
        state.editIndex = null
    }
}

export default function(state = init, action, args){
    // cach 1 dungf switch case
    // switch(action){
    //     case'add':
    //         const [title] = args
    //         return{
    //             ...state,
    //             todos:[...state.todos,{
    //                 title,
    //                 completed: false
    //             }]
    //         }
    //     default:
    //         return state
    // }
    // ! Cach 2:
    actions[action] && actions[action](state, ...args)
    return state

}