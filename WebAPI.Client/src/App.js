import './App.css';

import Navigation from './Navigation';
import Employee from './Employee';
import Home from './Home';
import Dependents from './Dependents';

import {
	BrowserRouter as Router,
	Routes,
	Route,
} from 'react-router-dom';

function App() {
	return (
		<Router>
			<div className='App'>
				<h3 className='m-3 d-flex justify-content-center'>Paymentum</h3>

				<Navigation />
				<br/>

				<Routes>
					<Route path='/' element={<Home/>} exact></Route>
					<Route path='/employee' element={<Employee/>}></Route>
					<Route path='/dependents' element={<Dependents/>}></Route>
				</Routes>
			</div>
		</Router>
	);
}

export default App;