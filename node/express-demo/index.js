const Joi = require("joi");
const express = require("express");

const app = express();

app.use(express.json());

const courses = [
  { id: 1, name: "course1" },
  { id: 2, name: "course2" },
  { id: 3, name: "course3" },
];

// PATH
let pathHome = "/";
let pathApiCourses = "/api/courses";
let pathApiCourse = "/api/courses/:id";

// Validation function
function validateCourse(course) {
  const schema = {
    name: Joi.string().min(3).required(),
  };

  return Joi.validate(course, schema);
}

// simply get homepage
app.get(pathHome, (req, res) => {
  res.send("Hello World!!");
});

// get all sourses
app.get(pathApiCourses, (req, res) => {
  res.send(courses);
});

// add course and joi validation
app.post(pathApiCourses, (req, res) => {
  const { error } = validateCourse(req.body);

  if (error) return res.status(400).send(error.details[0].message);

  const course = {
    id: courses.length + 1,
    name: req.body.name,
  };

  courses.push(course);
  res.send(course);
});

// Update the course with put request
app.put(pathApiCourse, (req, res) => {
  // Look up the course
  // If not existing, return 404
  const course = courses.find((c) => c.id === parseInt(req.params.id));
  if (!course)
    return res.status(404).send("The course with given ID was not found");

  // Validate
  // If invalid return 400
  const { error } = validateCourse(req.body);
  if (error) return res.status(400).send(error.details[0].message);

  // Update the course
  course.name = req.body.name;
  // Return updated course to the client
  res.send(course);
});

// get 1 exact course by id
app.get(pathApiCourse, (req, res) => {
  const course = courses.find((c) => c.id === parseInt(req.params.id));
  if (!course)
    return res.status(404).send("The course with given ID was not found");
  res.send(course.name);
});

// Delete course
app.delete(pathApiCourse, (req, res) => {
  // Look up the course
  // Not existing, return 404
  const course = courses.find((c) => c.id === parseInt(req.params.id));
  if (!course)
    return res.status(404).send("The course with given ID was not found");

  // Delete
  const index = courses.indexOf(course);
  courses.splice(index, 1);

  // Return the same course
  res.send(course);
});

// PORT
const port = process.env.PORT || 3000;
app.listen(port, () => {
  console.log(`Listening on port ${port}`);
});
