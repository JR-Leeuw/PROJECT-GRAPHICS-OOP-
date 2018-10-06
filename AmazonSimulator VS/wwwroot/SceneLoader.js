class Robot extends THREE.Group {
    constructor() {
        super();
        this.init();
    }
    init() {
        var Spawn = this;
        var geometry = new THREE.BoxGeometry(0.9, 0.3, 0.9);
        var cubeMaterials = [
            new THREE.MeshPhongMaterial({ map: new THREE.TextureLoader().load("textures/robot_side.png"), side: THREE.DoubleSide }), //LEFT
            new THREE.MeshPhongMaterial({ map: new THREE.TextureLoader().load("textures/robot_side.png"), side: THREE.DoubleSide }), //RIGHT
            new THREE.MeshPhongMaterial({ map: new THREE.TextureLoader().load("textures/robot_top.png"), side: THREE.DoubleSide }), //TOP
            new THREE.MeshPhongMaterial({ map: new THREE.TextureLoader().load("textures/robot_bottom.png"), side: THREE.DoubleSide }), //BOTTOM
            new THREE.MeshPhongMaterial({ map: new THREE.TextureLoader().load("textures/robot_front.png"), side: THREE.DoubleSide }), //FRONT
            new THREE.MeshPhongMaterial({ map: new THREE.TextureLoader().load("textures/robot_front.png"), side: THREE.DoubleSide }) //BACK
        ];
        var material = new THREE.MeshFaceMaterial(cubeMaterials);
        var robot = new THREE.Mesh(geometry, material);
        robot.position.y = 0.15;
        Spawn.add(robot);
        robot.receiveShadow = true;
        robot.castShadow = true;
    }
}

class Haystack extends THREE.Group {
    constructor() {
        super();
        this.init();
    }
    init() {

        LoadOBJModel("Models/HayStack/", "HayStack.obj", "Models/HayStack/", "HayStack.mtl", (mesh) => {

            mesh.scale.set(0.2, 0.2, 0.2);

            Spawn.add(mesh);

            //mesh.children[0].material = new THREE.MeshBasicMaterial({ color: 0xebf442 });
        });
    }
}
class Tractor extends THREE.Group {
    constructor() {
        super();
        this.init();
    }
    init() {
        var Spawn = this;
        LoadOBJModel("Models/tractor/", "tractor.obj", "Models/tractor/", "tractor.mtl", (mesh) => {
            mesh.scale.set(0.2, 0.2, 0.2);
            Spawn.add(mesh);

        });
    }
}


class Propeller extends THREE.Group {
    constructor() {
        super();
        this.init();
    }
    init() {
        var Spawn = this;
        
        LoadOBJModel("Models/propeller/", "CUPIC_PROPELLER.obj", "Models/propeller/", "CUPIC_PROPELLER.mtl", (mesh) => {
            mesh.scale.set(0.05, 0.05, 0.05);
            Spawn.add(mesh);


        });
    }

}

class roadOBJ extends THREE.Group {
    constructor() {
        super();
        this.init();
    }
    init() {
        var Spawn = this;
        LoadOBJModel("Models/RoadOBJ/", "Road.obj", "Models/RoadOBJ/", "Road.mtl", (mesh) => {
            mesh.scale.set(0.075, 0.075, 0.075);
            Spawn.add(mesh);
            

        });
    }
}
class Gate extends THREE.Group {
    constructor() {
        super();
        this.init();
    }
    init() {
        var Spawn = this;
        LoadOBJModel("Models/gate/", "Gate.obj", "Models/Gate/", "Gate.mtl", (mesh) => {
            mesh.scale.set(0.27, 0.27, 0.27);

            Spawn.add(mesh);
        });
       

    }
}
class Fence extends THREE.Group {
    constructor() {
        super();
        this.init();
    }
    init() {
        var Spawn = this;
        LoadOBJModel("Models/fences/", "PicketFence.obj", "Models/fences/", "PicketFence.mtl", (mesh) => {
            mesh.scale.set(1.3, 1.3, 1.3);
            Spawn.add(mesh);
            //mesh.rotation.y = Math.PI / 2
            
            
        });
        
        
        
    }
}
function LoadOBJModel(modelPath, modelName, texturePath, textureName, onload) {
    new THREE.MTLLoader()
        .setPath(texturePath)
        .load(textureName, function (materials) {

            materials.preload();

            new THREE.OBJLoader()
                .setPath(modelPath)
                .setMaterials(materials)
                .load(modelName, function (object) {
                    onload(object);
                }, function () { }, function (e) { console.log("Error loading model"); console.log(e); });
        });


}  