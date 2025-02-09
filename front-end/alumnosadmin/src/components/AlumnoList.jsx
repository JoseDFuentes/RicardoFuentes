// components/AlumnoList.jsx
import React, { useEffect, useState } from 'react';
import { Table, Button } from 'react-bootstrap';
import { getAlumnos, deleteAlumno } from '../services/api';
import { useNavigate } from 'react-router-dom'; 

const AlumnoList = () => {
  const [alumnos, setAlumnos] = useState([]);
  const navigate = useNavigate(); 

  useEffect(() => {
    fetchAlumnos();
  }, []);

  const fetchAlumnos = async () => {
    const data = await getAlumnos();
    setAlumnos(data);
  };

  const handleEdit = (id) => {
    navigate(`/edit/${id}`); 
  };

  const handleDelete = async (id) => {
    if (window.confirm('¿Estás seguro de eliminar este alumno?')) {
      await deleteAlumno(id);
      fetchAlumnos();
    }
  };

  return (
    <div>
      <h1>Listado de Alumnos</h1>
      <Button variant="primary" onClick={() => navigate('/create')}> 
        Crear Nuevo Alumno
      </Button>
      <Table striped bordered hover>
        <thead>
          <tr>
            <th>ID</th>
            <th>Nombre</th>
            <th>Fecha de Nacimiento</th>
            <th>Nombre del Padre</th>
            <th>Grado</th>
            <th>Sección</th>
            <th>Fecha de Ingreso</th>
            <th>Acciones</th>
          </tr>
        </thead>
        <tbody>
          {alumnos.map((alumno) => (
            <tr key={alumno.idAlumno}>
              <td>{alumno.idAlumno}</td>
              <td>{alumno.nombre}</td>
              <td>{alumno.fechaNacimiento}</td>
              <td>{alumno.nombrePadre}</td>
              <td>{alumno.grado}</td>
              <td>{alumno.seccion}</td>
              <td>{alumno.fechaIngreso}</td>
              <td>
                <Button variant="warning" onClick={() => handleEdit(alumno.idAlumno)}>
                  Editar
                </Button>{' '}
                <Button variant="danger" onClick={() => handleDelete(alumno.idAlumno)}>
                  Eliminar
                </Button>
              </td>
            </tr>
          ))}
        </tbody>
      </Table>
    </div>
  );
};

export default AlumnoList;