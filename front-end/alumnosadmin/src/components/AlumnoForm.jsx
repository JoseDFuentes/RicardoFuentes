// components/AlumnoForm.jsx
import React, { useState } from 'react';
import { Form, Button } from 'react-bootstrap';
import { createAlumno } from '../services/api';
import { useNavigate } from 'react-router-dom'; // Cambiar useHistory por useNavigate

const AlumnoForm = () => {
  const [alumno, setAlumno] = useState({
    nombre: '',
    fechaNacimiento: '',
    nombrePadre: '',
    grado: '',
    seccion: '',
    fechaIngreso: ''
  });
  const navigate = useNavigate(); // Cambiar useHistory por useNavigate

  const handleChange = (e) => {
    setAlumno({ ...alumno, [e.target.name]: e.target.value });
  };

  const handleSubmit = async (e) => {
    e.preventDefault();
    await createAlumno(alumno);
    navigate('/'); // Cambiar history.push por navigate
  };

  return (
    <div>
      <h1>Crear Nuevo Alumno</h1>
      <Form onSubmit={handleSubmit}>
      <Form.Group controlId="formId">
          <Form.Label>Nombre</Form.Label>
          <Form.Control
            type="text"
            name="IdAlumno"
            value={alumno.idAlumno}
            onChange={handleChange}
            required
          />
        </Form.Group>
        <Form.Group controlId="formNombre">
          <Form.Label>Nombre</Form.Label>
          <Form.Control
            type="text"
            name="Nombre"
            value={alumno.nombre}
            onChange={handleChange}
            required
          />
        </Form.Group>
        <Form.Group controlId="formFechaNacimiento">
          <Form.Label>Fecha de Nacimiento</Form.Label>
          <Form.Control
            type="date"
            name="FechaNacimiento"
            value={alumno.fechaNacimiento}
            onChange={handleChange}
            required
          />
        </Form.Group>
        <Form.Group controlId="formNombrePadre">
          <Form.Label>Nombre del Padre</Form.Label>
          <Form.Control
            type="text"
            name="NombrePadre"
            value={alumno.nombrePadre}
            onChange={handleChange}
            required
          />
        </Form.Group>
        <Form.Group controlId="formGrado">
          <Form.Label>Grado</Form.Label>
          <Form.Control
            type="text"
            name="Grado"
            value={alumno.grado}
            onChange={handleChange}
            required
          />
        </Form.Group>
        <Form.Group controlId="formSeccion">
          <Form.Label>Sección</Form.Label>
          <Form.Control
            type="text"
            name="Seccion"
            value={alumno.seccion}
            onChange={handleChange}
            required
          />
        </Form.Group>
        <Form.Group controlId="formFechaIngreso">
          <Form.Label>Fecha de Ingreso</Form.Label>
          <Form.Control
            type="date"
            name="FechaIngreso"
            value={alumno.fechaIngreso}
            onChange={handleChange}
            required
          />
        </Form.Group>
        <Button variant="primary" type="submit">
          Guardar
        </Button>{' '}
        <Button variant="secondary" onClick={() => navigate('/')}> 
          Cancelar
        </Button>
      </Form>
    </div>
  );
};

export default AlumnoForm;