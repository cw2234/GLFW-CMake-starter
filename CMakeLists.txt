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

set(
    hello_window
    src/hello_window.cpp
)

add_executable(hello_window WIN32 ${hello_window} ${GLAD_C})

