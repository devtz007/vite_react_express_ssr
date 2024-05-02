import ReactDOM from 'react-dom/client'
import { BrowserRouter } from 'react-router-dom'
import { App } from './App'
import "./styles.css"

ReactDOM.hydrateRoot(
  document.getElementById('app')!,
  <BrowserRouter>
    <App />
  </BrowserRouter>
)
