cmake_minimum_required(VERSION 3.20)

project(GLFW-CMake-starter)

find_package(OpenGL REQUIRED)

include_directories(${OPENGL_INCLUDE_DIRS})
include_directories("include")

set(GLFW_BUILD_DOCS OFF CACHE BOOL "GLFW lib only")
set(GLFW_INSTALL OFF CACHE BOOL "GLFW lib only")
set(GLAD_C "src/glad.c")
add_subdirectory(glfw)

link_libraries(${OPENGL_LIBRARIES} glfw)

# add_executable(hello_window WIN32 src/hello_window.cpp ${GLAD_C})
add_executable(hello_window src/hello_window.cpp ${GLAD_C})
add_executable(hello_triangle src/hello_triangle.cpp ${GLAD_C})
add_executable(hello_triangle1 src/hello_triangle1.cpp ${GLAD_C})
add_executable(hello_shaders src/hello_shaders.cpp ${GLAD_C})
add_executable(hello_shaders1 src/hello_shaders1.cpp ${GLAD_C})
add_executable(exercise_triangle src/exercise_triangle.cpp ${GLAD_C})

