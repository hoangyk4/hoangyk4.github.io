import html from '../core.js';



function Header(){
    return html`
        <header class="header">
            <h1>Quản lý công việc</h1>
            <input 
                class="new-todo" 
                placeholder="Bạn muốn làm gì?" 
                autofocus
                onkeyup="event.keyCode === 13 && dispatch('add', this.value.trim())"
            >
        </header>

    `
}
export default Header