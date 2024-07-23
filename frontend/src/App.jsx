import { useState, useEffect} from 'react'
import Course from './components/Course'
import './App.css'
import Stack from 'react-bootstrap/Stack'
import {Container, Row, Col} from 'react-bootstrap'

function App() {
  let [degreeData, setDegreeData] = useState(null);

  let [selectedDegree, setSelectedDegree] = useState(2452);

  let [semesterMap, setSemesterMap] = useState([[], [], [], [], [], []]);

  let [courseList, setCourseList] = useState(null);
  
  useEffect(() => {
    fetch("https://uqdegreeplannerapi.azurewebsites.net/api/degree")
    .then(response => response.json())
    .then(data => setDegreeData(data))
  }, []);

  function handleSubmit(e) {
    e.preventDefault();

    fetch(`https://uqdegreeplannerapi.azurewebsites.net/api/degreeCourses/${selectedDegree}`)
    .then(response => response.json())
    .then(data => setCourseList(data));
  }


  return (
    <>
    
    <div className="mainContainer">
      <div className="formContainer">
        <form onSubmit={handleSubmit}>
          <label htmlFor="degrees">Degrees</label>
          <select name="degrees" id="degrees" value={selectedDegree} onChange={(e)=>setSelectedDegree(e.target.key)}>
            {degreeData && degreeData.map(degree => <option key={degree.id} value={degree.name}>{degree.name}</option>)}
          </select>
          <input type="submit" value="Load Courses"/>
        </form>
      </div>

      <div className="stackContainer">
        <Stack direction={"vertical"} gap={3}>
          {courseList && courseList.map(course => <Course courseCode={course.code} courseName={course.name} />)}
        </Stack>
      </div>

   

    </div>

    <div className="sideContainer">
      <div className="gridContainer">
          <>{semesterMap.map(semesterSet=> <div className="semesterContainer">{semesterSet.map(course=>course.name)}</div>)}</>
    </div>
    </div>
    
    


  
    </>
  )
}

export default App
