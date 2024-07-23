import { useState, useEffect} from 'react'
import Card from 'react-bootstrap/Card'

function Course(props) {
 
    return(
        <>
            <Card style={{backgroundColor:"#6488ea", marginTop:'20px'}}>
                <Card.Title>{props.courseCode}</Card.Title>
                <Card.Body>{props.courseName}</Card.Body>
            </Card>
        </>
    )
}

export default Course
