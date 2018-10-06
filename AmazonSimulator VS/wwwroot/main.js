const canvas = document.getElementById("canvas");

const sceneManager = new SceneManager(canvas);
window.addEventListener('resize', onWindowResize, false);

render();

function animate() {
    requestAnimationFrame(animate);
    cameraControls.update();
    renderer.render(scene, camera);
}

function render() {
    requestAnimationFrame(render);
    sceneManager.update();
}


