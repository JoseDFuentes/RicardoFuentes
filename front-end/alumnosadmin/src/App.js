// App.js
import React from 'react';
import { BrowserRouter as Router, Route, Routes } from 'react-router-dom'; 
import AlumnoList from './components/AlumnoList';
import AlumnoForm from './components/AlumnoForm';
import AlumnoEdit from './components/AlumnoEdit';
import 'bootstrap/dist/css/bootstrap.min.css';

function App() {
  return (
    <Router>
      <div className="App">
        <Routes> {/* Cambiar Switch por Routes */}
          <Route path="/" element={<AlumnoList />} /> {/* Usar element en lugar de component */}
          <Route path="/create" element={<AlumnoForm />} />
          <Route path="/edit/:id" element={<AlumnoEdit />} />
        </Routes>
      </div>
    </Router>
  );
}

export default App;