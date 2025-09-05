cmake_minimum_required(VERSION 3.20)

project(GLFW-CMake-starter)

find_package(OpenGL REQUIRED)

include_directories(${OPENGL_INCLUDE_DIRS})
include_directories("include")

set(GLFW_BUILD_DOCS OFF CACHE BOOL "GLFW lib only")
set(GLFW_INSTALL OFF CACHE BOOL "GLFW lib only")
set(
LIB_FILES 
src/glad.c 
src/stb_image.cpp)
add_subdirectory(glfw)

link_libraries(${OPENGL_LIBRARIES} glfw)

# add_executable(hello_window WIN32 src/hello_window.cpp ${GLAD_C})
add_executable(hello_window src/hello_window.cpp ${LIB_FILES})
add_executable(hello_triangle src/hello_triangle.cpp ${LIB_FILES})
add_executable(hello_triangle1 src/hello_triangle1.cpp ${LIB_FILES})
add_executable(hello_shaders src/hello_shaders.cpp ${LIB_FILES})
add_executable(hello_shaders1 src/hello_shaders1.cpp ${LIB_FILES})
add_executable(exercise_triangle src/exercise_triangle.cpp ${LIB_FILES})
add_executable(hello_texture src/hello_texture.cpp ${LIB_FILES})
add_executable(translation src/translation.cpp ${LIB_FILES})
add_executable(coordinate_systems src/coordinate_systems.cpp ${LIB_FILES})
add_executable(camera src/camera.cpp ${LIB_FILES})
add_executable(camera_class src/camera_class.cpp ${LIB_FILES})
add_executable(color src/color.cpp ${LIB_FILES})
add_executable(basic_lighting src/basic_lighting.cpp ${LIB_FILES})
add_executable(materials src/materials.cpp ${LIB_FILES})

