class Api::RecordsController < ApplicationController

    def create 
        @recording = Record.new(record_params)
        if (current_user)
            @user = current_user;
            @record.user_id = current_user.id;
        end

        if @record.save
            render :show
        else 
            render json: @record.errors.full_messages, status: 422 
        end
    end

    # def show 
    #     @record = Record.find(params[:id])
    #     render "api/records/show"
    # end

    # def index 
    #     @user = current_user 
    #     render "api/records/index"
    # end 

    # def destroy 
    #     @record = Record.find(params[:id])
    #     # @user = User.find_by(id: @record.user_id)
    #     @record.destroy
    #     render "api/records/show"
    # end

    # def update 
    #     @record = Record.find(params[:id])
    #     @user = current_user;
    #     if @record.update(record_params)
    #         render "api/records/show"
    #     else 
    #     end 
    # end

    def record_params 
        params.require(:record).permit(:title, :description, :user_id)
    end
end
