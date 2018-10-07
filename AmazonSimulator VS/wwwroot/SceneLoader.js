
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
            new THREE.MeshPhongMaterial({ map: new THREE.TextureLoader().load("textures/owl1.png"), side: THREE.DoubleSide }), //TOP
            new THREE.MeshPhongMaterial({ map: new THREE.TextureLoader().load("textures/robot_bottom.png"), side: THREE.DoubleSide }), //BOTTOM
            new THREE.MeshPhongMaterial({ map: new THREE.TextureLoader().load("textures/robot_front.png"), side: THREE.DoubleSide }), //FRONT
            new THREE.MeshPhongMaterial({ map: new THREE.TextureLoader().load("textures/robot_front.png"), side: THREE.DoubleSide }) //BACK
        ];
        var material = new THREE.MeshFaceMaterial(cubeMaterials);
        var robot = new THREE.Mesh(geometry, material);
        robot.position.y = 0.15;
        Spawn.add(robot);
        
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
class Wheat extends THREE.Group {
    constructor() {
        super();
        this.init();
    }
    init() {
        var Spawn = this;
        LoadOBJModel("Models/wheat/", "FieldOfWheat.obj", "Models/Wheat/", "FieldOfWheat.mtl", (mesh) => {
            mesh.scale.set(0.1, 0.1, 0.3);
            Spawn.add(mesh);
            //mesh.rotation.y = Math.PI / 2;           
        });
    }
}
class Cow extends THREE.Group {
    constructor() {
        super();
        this.init();
    }
    init() {
        var Spawn = this;
        LoadOBJModel("Models/Cow/", "Cow.obj", "Models/Cow/", "Cow.mtl", (mesh) => {
            mesh.scale.set(0.2, 0.2, 0.2);
            Spawn.add(mesh);
            //mesh.rotation.y = Math.PI / 2
        });
    }
}
class Windmill extends THREE.Group {
    constructor() {
        super();
        this.init();
    }
    init() {
        var Spawn = this;
        LoadOBJModel("Models/modelWindmill/", "model.obj", "Models/modelWindmill/", "materials.mtl", (mesh) => {
            mesh.scale.set(10, 10, 10);
            Spawn.add(mesh);
            mesh.rotation.y = Math.PI;
        });
    }
}
class Barn extends THREE.Group {
    constructor() {
        super();
        this.init();
    }
    init() {
        var Spawn = this;
        LoadOBJModel("Models/BarnSM/", "SM_Barn_02.obj", "Models/BarnSM/", "SM_BARN_02.mtl", (mesh) => {
            mesh.scale.set(0.6, 0.6, 0.6);
            Spawn.add(mesh);
            mesh.rotation.y = Math.PI / 2;
        });
    }
}
class Woodenpath extends THREE.Group {
    constructor() {
        super();
        this.init();
    }
    init() {
        var Spawn = this;
        LoadOBJModel("Models/wood/", "model.obj", "Models/wood/", "materials.mtl", (mesh) => {
            mesh.scale.set(3, 1.5, 3);
            Spawn.add(mesh);
        });
    }
}
class Silo extends THREE.Group {
    constructor() {
        super();
        this.init();
    }
    init() {
        var Spawn = this;
        
        LoadOBJModel("Models/Silo/", "PUSHILIN_silo.obj", "Models/Silo/", "PUSHILIN_silo.mtl", (mesh) => {
            mesh.scale.set(4, 4, 4);
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
                    object.traverse(function (child) {
                        if (child instanceof THREE.Mesh) {
                            child.castShadow = true;
                        }
                    });
                }, function () { }, function (e) { console.log("Error loading model"); console.log(e); }); 
        });
}  