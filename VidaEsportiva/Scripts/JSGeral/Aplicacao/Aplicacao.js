function Aplicacao($vm, id) {
    this.$vm = $vm;
    this.$id = id;

    this.$api = {};

    this.$util = new AplicacaoUtil();

    this.init = function () {
        this.$vm && this.$vm.init();
    };
};